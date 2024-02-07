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
	public class Customer_Status_DataType : INotifyPropertyChanged
	{
		private Business_Entity_Status_ValueObjectType customer_Status_Value_ReferenceField;

		private Reason_for_Customer_Status_ChangeObjectType reason_for_Customer_Status_Change_ReferenceField;

		private string customer_Status_Change_Reason_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Entity_Status_ValueObjectType Customer_Status_Value_Reference
		{
			get
			{
				return this.customer_Status_Value_ReferenceField;
			}
			set
			{
				this.customer_Status_Value_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Status_Value_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Reason_for_Customer_Status_ChangeObjectType Reason_for_Customer_Status_Change_Reference
		{
			get
			{
				return this.reason_for_Customer_Status_Change_ReferenceField;
			}
			set
			{
				this.reason_for_Customer_Status_Change_ReferenceField = value;
				this.RaisePropertyChanged("Reason_for_Customer_Status_Change_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Status_Change_Reason_Description
		{
			get
			{
				return this.customer_Status_Change_Reason_DescriptionField;
			}
			set
			{
				this.customer_Status_Change_Reason_DescriptionField = value;
				this.RaisePropertyChanged("Customer_Status_Change_Reason_Description");
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
