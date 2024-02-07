using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Collective_Agreement_Factor_Parameter_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private Collective_Agreement_FactorObjectType collective_Agreement_Factor_ReferenceField;

		private Collective_Agreement_Factor_OptionObjectType[] collective_Agreement_Factor_Option_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Collective_Agreement_FactorObjectType Collective_Agreement_Factor_Reference
		{
			get
			{
				return this.collective_Agreement_Factor_ReferenceField;
			}
			set
			{
				this.collective_Agreement_Factor_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_Reference");
			}
		}

		[XmlElement("Collective_Agreement_Factor_Option_Reference", Order = 2)]
		public Collective_Agreement_Factor_OptionObjectType[] Collective_Agreement_Factor_Option_Reference
		{
			get
			{
				return this.collective_Agreement_Factor_Option_ReferenceField;
			}
			set
			{
				this.collective_Agreement_Factor_Option_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_Option_Reference");
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
