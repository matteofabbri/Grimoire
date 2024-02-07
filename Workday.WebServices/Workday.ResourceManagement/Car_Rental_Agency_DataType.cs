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
	public class Car_Rental_Agency_DataType : INotifyPropertyChanged
	{
		private string spend_Data_IDField;

		private string car_Rental_Agency_ValueField;

		private Merchant_CodeObjectType merchant_Code_ReferenceField;

		private Alternate_Merchant_Name_DataType[] alternate_Merchant_Name_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Data_ID
		{
			get
			{
				return this.spend_Data_IDField;
			}
			set
			{
				this.spend_Data_IDField = value;
				this.RaisePropertyChanged("Spend_Data_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Car_Rental_Agency_Value
		{
			get
			{
				return this.car_Rental_Agency_ValueField;
			}
			set
			{
				this.car_Rental_Agency_ValueField = value;
				this.RaisePropertyChanged("Car_Rental_Agency_Value");
			}
		}

		[XmlElement(Order = 2)]
		public Merchant_CodeObjectType Merchant_Code_Reference
		{
			get
			{
				return this.merchant_Code_ReferenceField;
			}
			set
			{
				this.merchant_Code_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Code_Reference");
			}
		}

		[XmlElement("Alternate_Merchant_Name_Data", Order = 3)]
		public Alternate_Merchant_Name_DataType[] Alternate_Merchant_Name_Data
		{
			get
			{
				return this.alternate_Merchant_Name_DataField;
			}
			set
			{
				this.alternate_Merchant_Name_DataField = value;
				this.RaisePropertyChanged("Alternate_Merchant_Name_Data");
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
