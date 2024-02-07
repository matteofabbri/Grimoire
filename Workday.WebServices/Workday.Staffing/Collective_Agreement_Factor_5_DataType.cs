using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Collective_Agreement_Factor_5_DataType : INotifyPropertyChanged
	{
		private Collective_Agreement_FactorObjectType collective_Agreement_Factor_5_ReferenceField;

		private Collective_Agreement_Factor_OptionObjectType collective_Agreement_Factor_Option_5_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Collective_Agreement_FactorObjectType Collective_Agreement_Factor_5_Reference
		{
			get
			{
				return this.collective_Agreement_Factor_5_ReferenceField;
			}
			set
			{
				this.collective_Agreement_Factor_5_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_5_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Collective_Agreement_Factor_OptionObjectType Collective_Agreement_Factor_Option_5_Reference
		{
			get
			{
				return this.collective_Agreement_Factor_Option_5_ReferenceField;
			}
			set
			{
				this.collective_Agreement_Factor_Option_5_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_Option_5_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
