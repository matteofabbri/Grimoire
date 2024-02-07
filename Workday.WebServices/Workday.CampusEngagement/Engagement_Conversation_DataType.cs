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
	public class Engagement_Conversation_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime entry_DateField;

		private StudentObjectType person_ReferenceField;

		private string descriptionField;

		private Engagement_Conversation_TopicObjectType[] conversation_Topic_ReferenceField;

		private bool initiated_by_InstitutionField;

		private bool initiated_by_InstitutionFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public StudentObjectType Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Conversation_Topic_Reference", Order = 4)]
		public Engagement_Conversation_TopicObjectType[] Conversation_Topic_Reference
		{
			get
			{
				return this.conversation_Topic_ReferenceField;
			}
			set
			{
				this.conversation_Topic_ReferenceField = value;
				this.RaisePropertyChanged("Conversation_Topic_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Initiated_by_Institution
		{
			get
			{
				return this.initiated_by_InstitutionField;
			}
			set
			{
				this.initiated_by_InstitutionField = value;
				this.RaisePropertyChanged("Initiated_by_Institution");
			}
		}

		[XmlIgnore]
		public bool Initiated_by_InstitutionSpecified
		{
			get
			{
				return this.initiated_by_InstitutionFieldSpecified;
			}
			set
			{
				this.initiated_by_InstitutionFieldSpecified = value;
				this.RaisePropertyChanged("Initiated_by_InstitutionSpecified");
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
