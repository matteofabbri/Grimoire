using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Emergency_Contact_DataType : INotifyPropertyChanged
	{
		private string emergency_Contact_IDField;

		private LanguageObjectType[] language_ReferenceField;

		private Emergency_Contact_PriorityObjectType emergency_Contact_Priority_ReferenceField;

		private bool primaryField;

		private bool primaryFieldSpecified;

		private decimal priorityField;

		private bool priorityFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Emergency_Contact_ID
		{
			get
			{
				return this.emergency_Contact_IDField;
			}
			set
			{
				this.emergency_Contact_IDField = value;
				this.RaisePropertyChanged("Emergency_Contact_ID");
			}
		}

		[XmlElement("Language_Reference", Order = 1)]
		public LanguageObjectType[] Language_Reference
		{
			get
			{
				return this.language_ReferenceField;
			}
			set
			{
				this.language_ReferenceField = value;
				this.RaisePropertyChanged("Language_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Emergency_Contact_PriorityObjectType Emergency_Contact_Priority_Reference
		{
			get
			{
				return this.emergency_Contact_Priority_ReferenceField;
			}
			set
			{
				this.emergency_Contact_Priority_ReferenceField = value;
				this.RaisePropertyChanged("Emergency_Contact_Priority_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Primary
		{
			get
			{
				return this.primaryField;
			}
			set
			{
				this.primaryField = value;
				this.RaisePropertyChanged("Primary");
			}
		}

		[XmlIgnore]
		public bool PrimarySpecified
		{
			get
			{
				return this.primaryFieldSpecified;
			}
			set
			{
				this.primaryFieldSpecified = value;
				this.RaisePropertyChanged("PrimarySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public decimal Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}

		[XmlIgnore]
		public bool PrioritySpecified
		{
			get
			{
				return this.priorityFieldSpecified;
			}
			set
			{
				this.priorityFieldSpecified = value;
				this.RaisePropertyChanged("PrioritySpecified");
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
