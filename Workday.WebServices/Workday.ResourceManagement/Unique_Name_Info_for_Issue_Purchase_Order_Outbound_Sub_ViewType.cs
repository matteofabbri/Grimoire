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
	public class Unique_Name_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private string wIDField;

		private string emailField;

		private string full_NameField;

		private string employee_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string WID
		{
			get
			{
				return this.wIDField;
			}
			set
			{
				this.wIDField = value;
				this.RaisePropertyChanged("WID");
			}
		}

		[XmlElement(Order = 1)]
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		[XmlElement(Order = 2)]
		public string Full_Name
		{
			get
			{
				return this.full_NameField;
			}
			set
			{
				this.full_NameField = value;
				this.RaisePropertyChanged("Full_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
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
