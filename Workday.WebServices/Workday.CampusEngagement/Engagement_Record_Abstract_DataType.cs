using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Record_Abstract_DataType : INotifyPropertyChanged
	{
		private DateTime entry_DateField;

		private string correlation_IDField;

		private Has_Engagement_RecordObjectType has_Engagement_Record_ReferenceField;

		private StudentObjectType prospect_ReferenceField;

		private Student_Engagement_ContainerObjectType engagement_Container_ReferenceField;

		private Engagement_Record_ActionObjectType engagement_Record_Action_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Entry_Date
		{
			get
			{
				return this.entry_DateField;
			}
			set
			{
				this.entry_DateField = value;
				this.RaisePropertyChanged("Entry_Date");
			}
		}

		[XmlElement(Order = 1)]
		public string Correlation_ID
		{
			get
			{
				return this.correlation_IDField;
			}
			set
			{
				this.correlation_IDField = value;
				this.RaisePropertyChanged("Correlation_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Has_Engagement_RecordObjectType Has_Engagement_Record_Reference
		{
			get
			{
				return this.has_Engagement_Record_ReferenceField;
			}
			set
			{
				this.has_Engagement_Record_ReferenceField = value;
				this.RaisePropertyChanged("Has_Engagement_Record_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public StudentObjectType Prospect_Reference
		{
			get
			{
				return this.prospect_ReferenceField;
			}
			set
			{
				this.prospect_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Engagement_ContainerObjectType Engagement_Container_Reference
		{
			get
			{
				return this.engagement_Container_ReferenceField;
			}
			set
			{
				this.engagement_Container_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Container_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Engagement_Record_ActionObjectType Engagement_Record_Action_Reference
		{
			get
			{
				return this.engagement_Record_Action_ReferenceField;
			}
			set
			{
				this.engagement_Record_Action_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Record_Action_Reference");
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
