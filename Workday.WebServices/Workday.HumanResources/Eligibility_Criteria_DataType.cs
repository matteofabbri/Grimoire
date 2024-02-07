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
	public class Eligibility_Criteria_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType field_ReferenceField;

		private DateTime as_Of_Effective_DateField;

		private bool as_Of_Effective_DateFieldSpecified;

		private DateTime as_Of_Entry_DateTimeField;

		private bool as_Of_Entry_DateTimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Document_FieldObjectType Field_Reference
		{
			get
			{
				return this.field_ReferenceField;
			}
			set
			{
				this.field_ReferenceField = value;
				this.RaisePropertyChanged("Field_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime As_Of_Effective_Date
		{
			get
			{
				return this.as_Of_Effective_DateField;
			}
			set
			{
				this.as_Of_Effective_DateField = value;
				this.RaisePropertyChanged("As_Of_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_Effective_DateSpecified
		{
			get
			{
				return this.as_Of_Effective_DateFieldSpecified;
			}
			set
			{
				this.as_Of_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime As_Of_Entry_DateTime
		{
			get
			{
				return this.as_Of_Entry_DateTimeField;
			}
			set
			{
				this.as_Of_Entry_DateTimeField = value;
				this.RaisePropertyChanged("As_Of_Entry_DateTime");
			}
		}

		[XmlIgnore]
		public bool As_Of_Entry_DateTimeSpecified
		{
			get
			{
				return this.as_Of_Entry_DateTimeFieldSpecified;
			}
			set
			{
				this.as_Of_Entry_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_Entry_DateTimeSpecified");
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
