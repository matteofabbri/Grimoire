using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Contract_Amendment_InformationType : INotifyPropertyChanged
	{
		private Award_Amendment_ReasonsObjectType award_Amendment_Reason_ReferenceField;

		private DateTime award_Amendment_Effective_DateField;

		private DateTime award_Amendment_Signed_DateField;

		private bool award_Amendment_Signed_DateFieldSpecified;

		private string award_Amendment_NumberField;

		private string award_Amendment_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Amendment_ReasonsObjectType Award_Amendment_Reason_Reference
		{
			get
			{
				return this.award_Amendment_Reason_ReferenceField;
			}
			set
			{
				this.award_Amendment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Award_Amendment_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Award_Amendment_Effective_Date
		{
			get
			{
				return this.award_Amendment_Effective_DateField;
			}
			set
			{
				this.award_Amendment_Effective_DateField = value;
				this.RaisePropertyChanged("Award_Amendment_Effective_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Award_Amendment_Signed_Date
		{
			get
			{
				return this.award_Amendment_Signed_DateField;
			}
			set
			{
				this.award_Amendment_Signed_DateField = value;
				this.RaisePropertyChanged("Award_Amendment_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Amendment_Signed_DateSpecified
		{
			get
			{
				return this.award_Amendment_Signed_DateFieldSpecified;
			}
			set
			{
				this.award_Amendment_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Amendment_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Award_Amendment_Number
		{
			get
			{
				return this.award_Amendment_NumberField;
			}
			set
			{
				this.award_Amendment_NumberField = value;
				this.RaisePropertyChanged("Award_Amendment_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Award_Amendment_Description
		{
			get
			{
				return this.award_Amendment_DescriptionField;
			}
			set
			{
				this.award_Amendment_DescriptionField = value;
				this.RaisePropertyChanged("Award_Amendment_Description");
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
