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
	public class Facilities_and_Administration_Rate_Agreement_DataType : INotifyPropertyChanged
	{
		private string facilities_and_Administration_Rate_Agreement_IDField;

		private string nameField;

		private DateTime dateField;

		private Facilities_and_Admin_Basis_TypeObjectType rate_Agreement_Basis_Type_ReferenceField;

		private string descriptionField;

		private Rate_Agreement_Cost_Rate_DataType[] rate_Agreement_Cost_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Administration_Rate_Agreement_ID
		{
			get
			{
				return this.facilities_and_Administration_Rate_Agreement_IDField;
			}
			set
			{
				this.facilities_and_Administration_Rate_Agreement_IDField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Rate_Agreement_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlElement(Order = 3)]
		public Facilities_and_Admin_Basis_TypeObjectType Rate_Agreement_Basis_Type_Reference
		{
			get
			{
				return this.rate_Agreement_Basis_Type_ReferenceField;
			}
			set
			{
				this.rate_Agreement_Basis_Type_ReferenceField = value;
				this.RaisePropertyChanged("Rate_Agreement_Basis_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("Rate_Agreement_Cost_Rate_Data", Order = 5)]
		public Rate_Agreement_Cost_Rate_DataType[] Rate_Agreement_Cost_Rate_Data
		{
			get
			{
				return this.rate_Agreement_Cost_Rate_DataField;
			}
			set
			{
				this.rate_Agreement_Cost_Rate_DataField = value;
				this.RaisePropertyChanged("Rate_Agreement_Cost_Rate_Data");
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
