using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF
{
    public class IoCContainer
	{
		#region - Fields & Properties
		private readonly Dictionary<Type, Type> _typeContainer = new Dictionary<Type, Type>();
		#endregion

		#region - Constructors
		public IoCContainer( ) { }
		#endregion

		#region - Methods
		public void Register<TInterface, TImplementation>(  ) where TImplementation : TInterface
		{
			_typeContainer[ typeof(TInterface) ] = typeof(TImplementation);
		}

		public TInterface Create<TInterface>(  )
		{
			return (TInterface)Create(typeof(TInterface));
		}

		private object Create(Type type )
		{
			var concreteType = _typeContainer[ type ];
			var defaultConsructor = concreteType.GetConstructor(new Type[ 0 ]);
			return defaultConsructor.Invoke(null);
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
