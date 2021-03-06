﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VINLibrary
{
    public static class ApiController
	{
		#region - Fields & Properties
		public static HttpClient ApiClient { get; set; } = new HttpClient();
		#endregion

		#region - Methods
		public static void InitializeClient( )
		{
			ApiClient = new HttpClient();
			ApiClient.DefaultRequestHeaders.Accept.Clear();
			ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
