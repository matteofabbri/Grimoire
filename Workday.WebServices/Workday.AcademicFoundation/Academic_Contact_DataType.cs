using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Contact_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Has_Academic_ContactObjectType has_Academic_Contact_ReferenceField;

		private string job_TitleField;

		private Legal_Name_DataType legal_Name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

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
		public Has_Academic_ContactObjectType Has_Academic_Contact_Reference
		{
			get
			{
				return this.has_Academic_Contact_ReferenceField;
			}
			set
			{
				this.has_Academic_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Has_Academic_Contact_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Title
		{
			get
			{
				return this.job_TitleField;
			}
			set
			{
				this.job_TitleField = value;
				this.RaisePropertyChanged("Job_Title");
			}
		}

		[XmlElement(Order = 3)]
		public Legal_Name_DataType Legal_Name_Data
		{
			get
			{
				return this.legal_Name_DataField;
			}
			set
			{
				this.legal_Name_DataField = value;
				this.RaisePropertyChanged("Legal_Name_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Contact_Information_DataType Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
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
