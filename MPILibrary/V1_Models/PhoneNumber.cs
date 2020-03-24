using MPILibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
	public class PhoneNumber : IPhoneNumber
	{
		private string[] split = { "(", ")", "-", " " };
		public string PhoneNumberString { get; set; }
		public int CountryCode { get; set; } = 1;
		public int AreaCode { get; set; }
		public int Exchange { get; set; }
		public int LocalNumber { get; set; }

		public PhoneNumber( ) { }
		public PhoneNumber( int country, int areaCode, int exchange, int local )
		{
			CountryCode = country;
			AreaCode = areaCode;
			Exchange = exchange;
			LocalNumber = local;
			PhoneNumberString = $"{country} - ({areaCode}) - {exchange} - {local}";
		}

		public PhoneNumber( int areaCode, int exchange, int local )
		{
			CountryCode = 1;
			AreaCode = areaCode;
			Exchange = exchange;
			LocalNumber = local;
			PhoneNumberString = $"({areaCode}) {exchange} - {local}";
		}

		public bool ParsePhoneNumber_OLD( string input )
		{
			bool pass = false;
			if (!String.IsNullOrWhiteSpace(input))
			{
				if (input.Length > 0)
				{
					string[] numberSplit = input.Split(split, StringSplitOptions.RemoveEmptyEntries);

					if (numberSplit.Length > 0)
					{
						if (numberSplit.Length <= 4)
						{
							bool success = false;
							for (int i = numberSplit.Length; i > 0; i--)
							{
								success = Int32.TryParse(numberSplit[ i ], out int output);
								if (success)
								{
									if (i == 0)
									{
										CountryCode = output;
									}
									else if (i == 1)
									{
										AreaCode = output;
									}
									else if (i == 2)
									{
										Exchange = output;
									}
									else if (i == 3)
									{
										LocalNumber = output;
									}
									else
									{
										//throw new PhoneNumberLengthException("Phone number outside index range", input);
									}
								}
								else
								{
									break;
								}
							}
							pass = true;
						}
					}
				}
			}
			return pass;
		}

		/// <summary>
		/// Not going to use this. Its kinda redundant. No one is gonna put al the fancy punctuation in.
		/// </summary>
		public bool ParsePhoneNumber_OLD( )
		{
			bool pass = false;
			if (!String.IsNullOrWhiteSpace(PhoneNumberString))
			{
				if (PhoneNumberString.Length > 0)
				{
					string[] numberSplit = PhoneNumberString.Split(split, StringSplitOptions.RemoveEmptyEntries);

					if (numberSplit.Length > 0)
					{
						if (numberSplit.Length <= 4)
						{
							bool success = false;
							for (int i = numberSplit.Length - 1; i > 0; i--)
							{
								
								success = Int32.TryParse(numberSplit[ i ], out int output);
								if (success)
								{
									if (i == 0)
									{
										CountryCode = output;
									}
									else if (i == 1)
									{
										AreaCode = output;
									}
									else if (i == 2)
									{
										Exchange = output;
									}
									else if (i == 3)
									{
										LocalNumber = output;
									}
									else
									{
										//throw new PhoneNumberLengthException("Phone number outside index range", input);
									}
									pass = true;
								}
								else
								{
									break;
								}
							}
						}
					}
				}
			}
			return pass;
		}

		public bool ParsePhoneNumber(  )
		{
			bool pass = false;
			if (!String.IsNullOrWhiteSpace(PhoneNumberString))
			{
				if (PhoneNumberString.Length > 7)
				{
					List<char> tempNumber = CleanInputNumber();

					if (tempNumber.Count > 0)
					{
						if (tempNumber.Count > 10)
						{
							List<char> tempNumberRev = tempNumber.Reverse<char>().ToList();

							char[] localRev = tempNumberRev.GetRange(0, 4).ToArray();
							char[] exchangeRev = tempNumberRev.GetRange(4, 3).ToArray();
							char[] areaCodeRev = tempNumberRev.GetRange(7, 3).ToArray();
							char[] countryRev = tempNumberRev.GetRange(10, tempNumberRev.Count - 10).ToArray();

							bool coSuccess = Int32.TryParse(ConvertChars(countryRev.Reverse().ToArray()), out int coOut);
							bool acSuccess = Int32.TryParse(ConvertChars(areaCodeRev.Reverse().ToArray()), out int acOut);
							bool exSuccess = Int32.TryParse(ConvertChars(exchangeRev.Reverse().ToArray()), out int exOut);
							bool locSuccess = Int32.TryParse(ConvertChars(localRev.Reverse().ToArray()), out int locOut);

							if (coSuccess && acSuccess && exSuccess && locSuccess)
							{
								pass = true;
							}
							else
								pass = false;

							CountryCode = coOut;
							AreaCode = acOut;
							Exchange = exOut;
							LocalNumber = locOut;
						}
						else if (tempNumber.Count == 10)
						{
							char[] areaCode = tempNumber.GetRange(0, 3).ToArray();
							char[] exchange = tempNumber.GetRange(3, 3).ToArray();
							char[] local = tempNumber.GetRange(6, 4).ToArray();

							bool acSuccess = Int32.TryParse(ConvertChars(areaCode), out int acOut);
							bool exSuccess = Int32.TryParse(ConvertChars(exchange), out int exOut);
							bool locSuccess = Int32.TryParse(ConvertChars(local), out int locOut);

							if (acSuccess && exSuccess && locSuccess)
							{
								pass = true;
							}
							else
								pass = false;

							AreaCode = acOut;
							Exchange = exOut;
							LocalNumber = locOut;
						}
						else if (tempNumber.Count == 7)
						{
							string exchange = tempNumber.GetRange(0, 3).ToString();
							string local = tempNumber.GetRange(3, 4).ToString();

							bool exSuccess = Int32.TryParse(exchange, out int exOut);
							bool locSuccess = Int32.TryParse(local, out int locOut);

							if (exSuccess && locSuccess)
							{
								pass = true;
							}
							else
								pass = false;

							Exchange = exOut;
							LocalNumber = locOut;
						}
					}
				}
			}
			else
				pass = true;

			return pass;
		}

		private List<char> CleanInputNumber( )
		{
			List<char> tempNumber = new List<char>();
			for (int i = 0; i < PhoneNumberString.Length; i++)
			{
				if (Char.IsDigit(PhoneNumberString[ i ]))
				{
					tempNumber.Add(PhoneNumberString[ i ]);
				}
			}
			return tempNumber;
		}

		private string ConvertChars( char[] input )
		{
			string output = "";

			foreach (var c in input)
			{
				output += c;
			}

			return output;
		}

		private void ParseNumber( string input )
		{

		}

		#region Full Properties
		public string NumberDisplay
		{
			get
			{
				string temp = CountryCode == 1 ? "" : $"{CountryCode} - ";
				return $"{temp}( {AreaCode} ) - {Exchange} - {LocalNumber}";
			}
		}
		#endregion
	}
}
