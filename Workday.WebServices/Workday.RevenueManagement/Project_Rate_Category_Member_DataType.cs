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
	public class Project_Rate_Category_Member_DataType : INotifyPropertyChanged
	{
		private string project_Rate_Category_Member_IDField;

		private string project_Rate_Category_Member_NameField;

		private bool in_UseField;

		private bool in_UseFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Rate_Category_Member_ID
		{
			get
			{
				return this.project_Rate_Category_Member_IDField;
			}
			set
			{
				this.project_Rate_Category_Member_IDField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Member_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Rate_Category_Member_Name
		{
			get
			{
				return this.project_Rate_Category_Member_NameField;
			}
			set
			{
				this.project_Rate_Category_Member_NameField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Member_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool In_Use
		{
			get
			{
				return this.in_UseField;
			}
			set
			{
				this.in_UseField = value;
				this.RaisePropertyChanged("In_Use");
			}
		}

		[XmlIgnore]
		public bool In_UseSpecified
		{
			get
			{
				return this.in_UseFieldSpecified;
			}
			set
			{
				this.in_UseFieldSpecified = value;
				this.RaisePropertyChanged("In_UseSpecified");
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
