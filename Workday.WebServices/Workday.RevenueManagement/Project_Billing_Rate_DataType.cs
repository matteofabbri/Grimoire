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
	public class Project_Billing_Rate_DataType : INotifyPropertyChanged
	{
		private Project_Rate_Category_MemberObjectType[] project_Rate_Category_Member_ReferenceField;

		private Project_RoleObjectType project_Role_ReferenceField;

		private decimal hourly_RateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Rate_Category_Member_Reference", Order = 0)]
		public Project_Rate_Category_MemberObjectType[] Project_Rate_Category_Member_Reference
		{
			get
			{
				return this.project_Rate_Category_Member_ReferenceField;
			}
			set
			{
				this.project_Rate_Category_Member_ReferenceField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Member_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Project_RoleObjectType Project_Role_Reference
		{
			get
			{
				return this.project_Role_ReferenceField;
			}
			set
			{
				this.project_Role_ReferenceField = value;
				this.RaisePropertyChanged("Project_Role_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Hourly_Rate
		{
			get
			{
				return this.hourly_RateField;
			}
			set
			{
				this.hourly_RateField = value;
				this.RaisePropertyChanged("Hourly_Rate");
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
