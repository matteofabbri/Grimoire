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
	public class Beneficiary_Data_WWSType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_Order_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement("Court_Order_Replacement_Data", Order = 1)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order_Replacement_Data
		{
			get
			{
				return this.court_Order_Replacement_DataField;
			}
			set
			{
				this.court_Order_Replacement_DataField = value;
				this.RaisePropertyChanged("Court_Order_Replacement_Data");
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
