using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_Type_DataType : INotifyPropertyChanged
	{
		private string review_Type_IDField;

		private string review_Type_NameField;

		private Review_CategoryObjectType review_Type_Category_ReferenceField;

		private bool review_Initiated_for_EmployeeField;

		private bool review_Initiated_for_EmployeeFieldSpecified;

		private bool review_Initiated_by_EmployeeField;

		private bool review_Initiated_by_EmployeeFieldSpecified;

		private decimal used_by_Templates_CountField;

		private bool used_by_Templates_CountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Review_Type_ID
		{
			get
			{
				return this.review_Type_IDField;
			}
			set
			{
				this.review_Type_IDField = value;
				this.RaisePropertyChanged("Review_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Review_Type_Name
		{
			get
			{
				return this.review_Type_NameField;
			}
			set
			{
				this.review_Type_NameField = value;
				this.RaisePropertyChanged("Review_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Review_CategoryObjectType Review_Type_Category_Reference
		{
			get
			{
				return this.review_Type_Category_ReferenceField;
			}
			set
			{
				this.review_Type_Category_ReferenceField = value;
				this.RaisePropertyChanged("Review_Type_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Review_Initiated_for_Employee
		{
			get
			{
				return this.review_Initiated_for_EmployeeField;
			}
			set
			{
				this.review_Initiated_for_EmployeeField = value;
				this.RaisePropertyChanged("Review_Initiated_for_Employee");
			}
		}

		[XmlIgnore]
		public bool Review_Initiated_for_EmployeeSpecified
		{
			get
			{
				return this.review_Initiated_for_EmployeeFieldSpecified;
			}
			set
			{
				this.review_Initiated_for_EmployeeFieldSpecified = value;
				this.RaisePropertyChanged("Review_Initiated_for_EmployeeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Review_Initiated_by_Employee
		{
			get
			{
				return this.review_Initiated_by_EmployeeField;
			}
			set
			{
				this.review_Initiated_by_EmployeeField = value;
				this.RaisePropertyChanged("Review_Initiated_by_Employee");
			}
		}

		[XmlIgnore]
		public bool Review_Initiated_by_EmployeeSpecified
		{
			get
			{
				return this.review_Initiated_by_EmployeeFieldSpecified;
			}
			set
			{
				this.review_Initiated_by_EmployeeFieldSpecified = value;
				this.RaisePropertyChanged("Review_Initiated_by_EmployeeSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Used_by_Templates_Count
		{
			get
			{
				return this.used_by_Templates_CountField;
			}
			set
			{
				this.used_by_Templates_CountField = value;
				this.RaisePropertyChanged("Used_by_Templates_Count");
			}
		}

		[XmlIgnore]
		public bool Used_by_Templates_CountSpecified
		{
			get
			{
				return this.used_by_Templates_CountFieldSpecified;
			}
			set
			{
				this.used_by_Templates_CountFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Templates_CountSpecified");
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
