using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Income_Distribution_Rule_DataType : INotifyPropertyChanged
	{
		private Income_Distribution_Amount_Rule_DataType[] flat_Amount_Rule_DataField;

		private Income_Distribution_Percent_Rule_DataType[] percent_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Flat_Amount_Rule_Data", Order = 0)]
		public Income_Distribution_Amount_Rule_DataType[] Flat_Amount_Rule_Data
		{
			get
			{
				return this.flat_Amount_Rule_DataField;
			}
			set
			{
				this.flat_Amount_Rule_DataField = value;
				this.RaisePropertyChanged("Flat_Amount_Rule_Data");
			}
		}

		[XmlElement("Percent_Rule_Data", Order = 1)]
		public Income_Distribution_Percent_Rule_DataType[] Percent_Rule_Data
		{
			get
			{
				return this.percent_Rule_DataField;
			}
			set
			{
				this.percent_Rule_DataField = value;
				this.RaisePropertyChanged("Percent_Rule_Data");
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
