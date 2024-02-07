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
	public class Facilities_and_Admin_Cost_Rate_Type_Type_Request_CriteriaType : INotifyPropertyChanged
	{
		private string facilities_and_Admin_Cost_Rate_Type_Type_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Admin_Cost_Rate_Type_Type_Name
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_NameField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_NameField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Name");
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
