using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Integration_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Payment_CategoryObjectType[] payment_Category_ReferenceField;

		private CountryObjectType[] country_ReferenceField;

		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private decimal maximum_Payments_Per_GroupField;

		private bool maximum_Payments_Per_GroupFieldSpecified;

		private Twenty_Four_Hour_TimeObjectType cut_Off_Time_ReferenceField;

		private Check_Print_Layout_AbstractObjectType check_Print_Layout_ReferenceField;

		private Unique_IdentifierObjectType outsourced_Bank_Provider_ReferenceField;

		private bool receives_AcknowledgementField;

		private bool receives_AcknowledgementFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement("Payment_Category_Reference", Order = 2)]
		public Payment_CategoryObjectType[] Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
			}
		}

		[XmlElement("Country_Reference", Order = 3)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Integration_System__Audited_ObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Maximum_Payments_Per_Group
		{
			get
			{
				return this.maximum_Payments_Per_GroupField;
			}
			set
			{
				this.maximum_Payments_Per_GroupField = value;
				this.RaisePropertyChanged("Maximum_Payments_Per_Group");
			}
		}

		[XmlIgnore]
		public bool Maximum_Payments_Per_GroupSpecified
		{
			get
			{
				return this.maximum_Payments_Per_GroupFieldSpecified;
			}
			set
			{
				this.maximum_Payments_Per_GroupFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Payments_Per_GroupSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Twenty_Four_Hour_TimeObjectType Cut_Off_Time_Reference
		{
			get
			{
				return this.cut_Off_Time_ReferenceField;
			}
			set
			{
				this.cut_Off_Time_ReferenceField = value;
				this.RaisePropertyChanged("Cut_Off_Time_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Check_Print_Layout_AbstractObjectType Check_Print_Layout_Reference
		{
			get
			{
				return this.check_Print_Layout_ReferenceField;
			}
			set
			{
				this.check_Print_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Check_Print_Layout_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Unique_IdentifierObjectType Outsourced_Bank_Provider_Reference
		{
			get
			{
				return this.outsourced_Bank_Provider_ReferenceField;
			}
			set
			{
				this.outsourced_Bank_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Outsourced_Bank_Provider_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Receives_Acknowledgement
		{
			get
			{
				return this.receives_AcknowledgementField;
			}
			set
			{
				this.receives_AcknowledgementField = value;
				this.RaisePropertyChanged("Receives_Acknowledgement");
			}
		}

		[XmlIgnore]
		public bool Receives_AcknowledgementSpecified
		{
			get
			{
				return this.receives_AcknowledgementFieldSpecified;
			}
			set
			{
				this.receives_AcknowledgementFieldSpecified = value;
				this.RaisePropertyChanged("Receives_AcknowledgementSpecified");
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
