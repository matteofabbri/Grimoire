using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Search_Service_Definition_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private Student_Recruiting_CampaignObjectType student_Recruiting_Campaign_ReferenceField;

		private Search_ServiceObjectType search_Service_ReferenceField;

		private DateTime date_of_SearchField;

		private bool date_of_SearchFieldSpecified;

		private string search_IdentifierField;

		private string descriptionField;

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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Recruiting_CampaignObjectType Student_Recruiting_Campaign_Reference
		{
			get
			{
				return this.student_Recruiting_Campaign_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Campaign_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Campaign_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Search_ServiceObjectType Search_Service_Reference
		{
			get
			{
				return this.search_Service_ReferenceField;
			}
			set
			{
				this.search_Service_ReferenceField = value;
				this.RaisePropertyChanged("Search_Service_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_of_Search
		{
			get
			{
				return this.date_of_SearchField;
			}
			set
			{
				this.date_of_SearchField = value;
				this.RaisePropertyChanged("Date_of_Search");
			}
		}

		[XmlIgnore]
		public bool Date_of_SearchSpecified
		{
			get
			{
				return this.date_of_SearchFieldSpecified;
			}
			set
			{
				this.date_of_SearchFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_SearchSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Search_Identifier
		{
			get
			{
				return this.search_IdentifierField;
			}
			set
			{
				this.search_IdentifierField = value;
				this.RaisePropertyChanged("Search_Identifier");
			}
		}

		[XmlElement(Order = 6)]
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
