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
	public class Marketing_Activity_Definition_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string marketing_Activity_Definition_NameField;

		private Student_Recruiting_CampaignObjectType student_Recruiting_Campaign_ReferenceField;

		private Marketing_TypeObjectType marketing_Type_ReferenceField;

		private string marketing_Activity_Definition_DescriptionField;

		private string marketing_Activity_Definition_URLField;

		private Marketing_Activity_Definition_Attachment_DataType[] marketing_Activity_Definition_Attachment_DataField;

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
		public string Marketing_Activity_Definition_Name
		{
			get
			{
				return this.marketing_Activity_Definition_NameField;
			}
			set
			{
				this.marketing_Activity_Definition_NameField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Name");
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
		public Marketing_TypeObjectType Marketing_Type_Reference
		{
			get
			{
				return this.marketing_Type_ReferenceField;
			}
			set
			{
				this.marketing_Type_ReferenceField = value;
				this.RaisePropertyChanged("Marketing_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Marketing_Activity_Definition_Description
		{
			get
			{
				return this.marketing_Activity_Definition_DescriptionField;
			}
			set
			{
				this.marketing_Activity_Definition_DescriptionField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Description");
			}
		}

		[XmlElement(Order = 5)]
		public string Marketing_Activity_Definition_URL
		{
			get
			{
				return this.marketing_Activity_Definition_URLField;
			}
			set
			{
				this.marketing_Activity_Definition_URLField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_URL");
			}
		}

		[XmlElement("Marketing_Activity_Definition_Attachment_Data", Order = 6)]
		public Marketing_Activity_Definition_Attachment_DataType[] Marketing_Activity_Definition_Attachment_Data
		{
			get
			{
				return this.marketing_Activity_Definition_Attachment_DataField;
			}
			set
			{
				this.marketing_Activity_Definition_Attachment_DataField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Attachment_Data");
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
