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
	public class Award_Personnel_DataType : INotifyPropertyChanged
	{
		private Award_PersonnelObjectType award_Personnel_ReferenceField;

		private string award_Personnel_Reference_IDField;

		private Personnel_WorkerObjectType award_Personnel_Person_ReferenceField;

		private Award_Personnel_ResponsibilityObjectType award_Personnel_Responsibility_ReferenceField;

		private bool award_Personnel_Key_PersonnelField;

		private bool award_Personnel_Key_PersonnelFieldSpecified;

		private Award_Personnel_Line_DataType[] award_Personnel_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_PersonnelObjectType Award_Personnel_Reference
		{
			get
			{
				return this.award_Personnel_ReferenceField;
			}
			set
			{
				this.award_Personnel_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Personnel_Reference_ID
		{
			get
			{
				return this.award_Personnel_Reference_IDField;
			}
			set
			{
				this.award_Personnel_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Personnel_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Personnel_WorkerObjectType Award_Personnel_Person_Reference
		{
			get
			{
				return this.award_Personnel_Person_ReferenceField;
			}
			set
			{
				this.award_Personnel_Person_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Person_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Award_Personnel_ResponsibilityObjectType Award_Personnel_Responsibility_Reference
		{
			get
			{
				return this.award_Personnel_Responsibility_ReferenceField;
			}
			set
			{
				this.award_Personnel_Responsibility_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Award_Personnel_Key_Personnel
		{
			get
			{
				return this.award_Personnel_Key_PersonnelField;
			}
			set
			{
				this.award_Personnel_Key_PersonnelField = value;
				this.RaisePropertyChanged("Award_Personnel_Key_Personnel");
			}
		}

		[XmlIgnore]
		public bool Award_Personnel_Key_PersonnelSpecified
		{
			get
			{
				return this.award_Personnel_Key_PersonnelFieldSpecified;
			}
			set
			{
				this.award_Personnel_Key_PersonnelFieldSpecified = value;
				this.RaisePropertyChanged("Award_Personnel_Key_PersonnelSpecified");
			}
		}

		[XmlElement("Award_Personnel_Line_Data", Order = 5)]
		public Award_Personnel_Line_DataType[] Award_Personnel_Line_Data
		{
			get
			{
				return this.award_Personnel_Line_DataField;
			}
			set
			{
				this.award_Personnel_Line_DataField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Data");
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
