using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Matrix_Amount_Based_DataType : INotifyPropertyChanged
	{
		private FrequencyObjectType default_Frequency_ReferenceField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private Condition_RuleObjectType[] compensation_Matrix_Target_Rules_ReferenceField;

		private Compensation_Matrix_Entry_Amount_Based_DataType[] compensation_Matrix_Entry_Amount_Based_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public FrequencyObjectType Default_Frequency_Reference
		{
			get
			{
				return this.default_Frequency_ReferenceField;
			}
			set
			{
				this.default_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Frequency_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CurrencyObjectType Default_Currency_Reference
		{
			get
			{
				return this.default_Currency_ReferenceField;
			}
			set
			{
				this.default_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Currency_Reference");
			}
		}

		[XmlElement("Compensation_Matrix_Target_Rules_Reference", Order = 2)]
		public Condition_RuleObjectType[] Compensation_Matrix_Target_Rules_Reference
		{
			get
			{
				return this.compensation_Matrix_Target_Rules_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_Target_Rules_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Target_Rules_Reference");
			}
		}

		[XmlElement("Compensation_Matrix_Entry_Amount_Based_Data", Order = 3)]
		public Compensation_Matrix_Entry_Amount_Based_DataType[] Compensation_Matrix_Entry_Amount_Based_Data
		{
			get
			{
				return this.compensation_Matrix_Entry_Amount_Based_DataField;
			}
			set
			{
				this.compensation_Matrix_Entry_Amount_Based_DataField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Entry_Amount_Based_Data");
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
