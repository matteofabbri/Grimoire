using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Additional_Input_DetailsType : INotifyPropertyChanged
	{
		private Related_Calculation__All_ObjectType related_Calculation_ReferenceField;

		private decimal input_ValueField;

		private bool input_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Related_Calculation__All_ObjectType Related_Calculation_Reference
		{
			get
			{
				return this.related_Calculation_ReferenceField;
			}
			set
			{
				this.related_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Related_Calculation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Input_Value
		{
			get
			{
				return this.input_ValueField;
			}
			set
			{
				this.input_ValueField = value;
				this.RaisePropertyChanged("Input_Value");
			}
		}

		[XmlIgnore]
		public bool Input_ValueSpecified
		{
			get
			{
				return this.input_ValueFieldSpecified;
			}
			set
			{
				this.input_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Input_ValueSpecified");
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
