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
	public class Salary_Over_The_Cap_Type_DataType : INotifyPropertyChanged
	{
		private string salary_Over_The_Cap_Type_IDField;

		private string salary_Over_The_Cap_Type_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Salary_Over_The_Cap_Type_ID
		{
			get
			{
				return this.salary_Over_The_Cap_Type_IDField;
			}
			set
			{
				this.salary_Over_The_Cap_Type_IDField = value;
				this.RaisePropertyChanged("Salary_Over_The_Cap_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Salary_Over_The_Cap_Type_Name
		{
			get
			{
				return this.salary_Over_The_Cap_Type_NameField;
			}
			set
			{
				this.salary_Over_The_Cap_Type_NameField = value;
				this.RaisePropertyChanged("Salary_Over_The_Cap_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
