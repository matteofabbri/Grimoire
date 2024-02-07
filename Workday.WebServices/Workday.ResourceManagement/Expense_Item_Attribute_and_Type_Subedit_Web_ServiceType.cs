using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Item_Attribute_and_Type_Subedit_Web_ServiceType : INotifyPropertyChanged
	{
		private Expense_Item_Attribute_TypeObjectType expense_Item_Attribute_Type_ReferenceField;

		private bool display_to_User_on_Expense_ReportField;

		private bool display_to_User_on_Expense_ReportFieldSpecified;

		private bool required_on_Expense_ReportField;

		private bool required_on_Expense_ReportFieldSpecified;

		private bool display_to_User_on_Spend_AuthorizationField;

		private bool display_to_User_on_Spend_AuthorizationFieldSpecified;

		private bool required_on_Spend_AuthorizationField;

		private bool required_on_Spend_AuthorizationFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Expense_Item_Attribute_TypeObjectType Expense_Item_Attribute_Type_Reference
		{
			get
			{
				return this.expense_Item_Attribute_Type_ReferenceField;
			}
			set
			{
				this.expense_Item_Attribute_Type_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Display_to_User_on_Expense_Report
		{
			get
			{
				return this.display_to_User_on_Expense_ReportField;
			}
			set
			{
				this.display_to_User_on_Expense_ReportField = value;
				this.RaisePropertyChanged("Display_to_User_on_Expense_Report");
			}
		}

		[XmlIgnore]
		public bool Display_to_User_on_Expense_ReportSpecified
		{
			get
			{
				return this.display_to_User_on_Expense_ReportFieldSpecified;
			}
			set
			{
				this.display_to_User_on_Expense_ReportFieldSpecified = value;
				this.RaisePropertyChanged("Display_to_User_on_Expense_ReportSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Required_on_Expense_Report
		{
			get
			{
				return this.required_on_Expense_ReportField;
			}
			set
			{
				this.required_on_Expense_ReportField = value;
				this.RaisePropertyChanged("Required_on_Expense_Report");
			}
		}

		[XmlIgnore]
		public bool Required_on_Expense_ReportSpecified
		{
			get
			{
				return this.required_on_Expense_ReportFieldSpecified;
			}
			set
			{
				this.required_on_Expense_ReportFieldSpecified = value;
				this.RaisePropertyChanged("Required_on_Expense_ReportSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Display_to_User_on_Spend_Authorization
		{
			get
			{
				return this.display_to_User_on_Spend_AuthorizationField;
			}
			set
			{
				this.display_to_User_on_Spend_AuthorizationField = value;
				this.RaisePropertyChanged("Display_to_User_on_Spend_Authorization");
			}
		}

		[XmlIgnore]
		public bool Display_to_User_on_Spend_AuthorizationSpecified
		{
			get
			{
				return this.display_to_User_on_Spend_AuthorizationFieldSpecified;
			}
			set
			{
				this.display_to_User_on_Spend_AuthorizationFieldSpecified = value;
				this.RaisePropertyChanged("Display_to_User_on_Spend_AuthorizationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Required_on_Spend_Authorization
		{
			get
			{
				return this.required_on_Spend_AuthorizationField;
			}
			set
			{
				this.required_on_Spend_AuthorizationField = value;
				this.RaisePropertyChanged("Required_on_Spend_Authorization");
			}
		}

		[XmlIgnore]
		public bool Required_on_Spend_AuthorizationSpecified
		{
			get
			{
				return this.required_on_Spend_AuthorizationFieldSpecified;
			}
			set
			{
				this.required_on_Spend_AuthorizationFieldSpecified = value;
				this.RaisePropertyChanged("Required_on_Spend_AuthorizationSpecified");
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
