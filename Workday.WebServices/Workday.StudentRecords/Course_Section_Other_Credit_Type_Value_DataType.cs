using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Course_Section_Other_Credit_Type_Value_DataType : INotifyPropertyChanged
	{
		private Other_Credit_TypeObjectType[] other_Credit_Type_ReferenceField;

		private decimal other_Credit_ValueField;

		private bool other_Credit_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Other_Credit_Type_Reference", Order = 0)]
		public Other_Credit_TypeObjectType[] Other_Credit_Type_Reference
		{
			get
			{
				return this.other_Credit_Type_ReferenceField;
			}
			set
			{
				this.other_Credit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Other_Credit_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Other_Credit_Value
		{
			get
			{
				return this.other_Credit_ValueField;
			}
			set
			{
				this.other_Credit_ValueField = value;
				this.RaisePropertyChanged("Other_Credit_Value");
			}
		}

		[XmlIgnore]
		public bool Other_Credit_ValueSpecified
		{
			get
			{
				return this.other_Credit_ValueFieldSpecified;
			}
			set
			{
				this.other_Credit_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Other_Credit_ValueSpecified");
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
