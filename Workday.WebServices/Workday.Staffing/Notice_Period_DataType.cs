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
	public class Notice_Period_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType notice_Period_ReferenceField;

		private decimal notice_Period_DurationField;

		private bool notice_Period_DurationFieldSpecified;

		private Unique_IdentifierObjectType notice_Period_Unit_ReferenceField;

		private bool notice_Period_Is_CustomField;

		private bool notice_Period_Is_CustomFieldSpecified;

		private Unique_IdentifierObjectType overridden_Notice_Period_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Notice_Period_Reference
		{
			get
			{
				return this.notice_Period_ReferenceField;
			}
			set
			{
				this.notice_Period_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Notice_Period_Duration
		{
			get
			{
				return this.notice_Period_DurationField;
			}
			set
			{
				this.notice_Period_DurationField = value;
				this.RaisePropertyChanged("Notice_Period_Duration");
			}
		}

		[XmlIgnore]
		public bool Notice_Period_DurationSpecified
		{
			get
			{
				return this.notice_Period_DurationFieldSpecified;
			}
			set
			{
				this.notice_Period_DurationFieldSpecified = value;
				this.RaisePropertyChanged("Notice_Period_DurationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Notice_Period_Unit_Reference
		{
			get
			{
				return this.notice_Period_Unit_ReferenceField;
			}
			set
			{
				this.notice_Period_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Unit_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Notice_Period_Is_Custom
		{
			get
			{
				return this.notice_Period_Is_CustomField;
			}
			set
			{
				this.notice_Period_Is_CustomField = value;
				this.RaisePropertyChanged("Notice_Period_Is_Custom");
			}
		}

		[XmlIgnore]
		public bool Notice_Period_Is_CustomSpecified
		{
			get
			{
				return this.notice_Period_Is_CustomFieldSpecified;
			}
			set
			{
				this.notice_Period_Is_CustomFieldSpecified = value;
				this.RaisePropertyChanged("Notice_Period_Is_CustomSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Unique_IdentifierObjectType Overridden_Notice_Period_Reference
		{
			get
			{
				return this.overridden_Notice_Period_ReferenceField;
			}
			set
			{
				this.overridden_Notice_Period_ReferenceField = value;
				this.RaisePropertyChanged("Overridden_Notice_Period_Reference");
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
