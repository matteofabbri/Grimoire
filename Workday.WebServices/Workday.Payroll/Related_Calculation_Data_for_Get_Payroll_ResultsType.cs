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
	public class Related_Calculation_Data_for_Get_Payroll_ResultsType : INotifyPropertyChanged
	{
		private Related_Calculation__All_ObjectType related_Calculation_ReferenceField;

		private decimal related_Amount_ValueField;

		private bool related_Amount_ValueFieldSpecified;

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
		public decimal Related_Amount_Value
		{
			get
			{
				return this.related_Amount_ValueField;
			}
			set
			{
				this.related_Amount_ValueField = value;
				this.RaisePropertyChanged("Related_Amount_Value");
			}
		}

		[XmlIgnore]
		public bool Related_Amount_ValueSpecified
		{
			get
			{
				return this.related_Amount_ValueFieldSpecified;
			}
			set
			{
				this.related_Amount_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Related_Amount_ValueSpecified");
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
