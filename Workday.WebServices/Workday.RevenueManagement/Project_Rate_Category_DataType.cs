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
	public class Project_Rate_Category_DataType : INotifyPropertyChanged
	{
		private string project_Rate_Category_IDField;

		private string project_Rate_Category_NameField;

		private string descriptionField;

		private Project_Rate_Category_Member_DataType[] project_Rate_Category_MembersField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Rate_Category_ID
		{
			get
			{
				return this.project_Rate_Category_IDField;
			}
			set
			{
				this.project_Rate_Category_IDField = value;
				this.RaisePropertyChanged("Project_Rate_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Rate_Category_Name
		{
			get
			{
				return this.project_Rate_Category_NameField;
			}
			set
			{
				this.project_Rate_Category_NameField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Project_Rate_Category_Members", Order = 3)]
		public Project_Rate_Category_Member_DataType[] Project_Rate_Category_Members
		{
			get
			{
				return this.project_Rate_Category_MembersField;
			}
			set
			{
				this.project_Rate_Category_MembersField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Members");
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
