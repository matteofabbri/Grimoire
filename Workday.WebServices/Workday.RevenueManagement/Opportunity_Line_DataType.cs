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
	public class Opportunity_Line_DataType : INotifyPropertyChanged
	{
		private Opportunity_LineObjectType opportunity_Line_ReferenceField;

		private string opportunity_Line_Reference_IDField;

		private string product_DescriptionField;

		private string product_CodeField;

		private string product_NameField;

		private string revenue_CategoryField;

		private decimal unit_CostField;

		private decimal quantityField;

		private Invoicing_Schedule_Line_for_Opportunity_Line_DataType[] opportunity_Line_Schedule_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Opportunity_LineObjectType Opportunity_Line_Reference
		{
			get
			{
				return this.opportunity_Line_ReferenceField;
			}
			set
			{
				this.opportunity_Line_ReferenceField = value;
				this.RaisePropertyChanged("Opportunity_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Opportunity_Line_Reference_ID
		{
			get
			{
				return this.opportunity_Line_Reference_IDField;
			}
			set
			{
				this.opportunity_Line_Reference_IDField = value;
				this.RaisePropertyChanged("Opportunity_Line_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Product_Description
		{
			get
			{
				return this.product_DescriptionField;
			}
			set
			{
				this.product_DescriptionField = value;
				this.RaisePropertyChanged("Product_Description");
			}
		}

		[XmlElement(Order = 3)]
		public string Product_Code
		{
			get
			{
				return this.product_CodeField;
			}
			set
			{
				this.product_CodeField = value;
				this.RaisePropertyChanged("Product_Code");
			}
		}

		[XmlElement(Order = 4)]
		public string Product_Name
		{
			get
			{
				return this.product_NameField;
			}
			set
			{
				this.product_NameField = value;
				this.RaisePropertyChanged("Product_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Revenue_Category
		{
			get
			{
				return this.revenue_CategoryField;
			}
			set
			{
				this.revenue_CategoryField = value;
				this.RaisePropertyChanged("Revenue_Category");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlElement("Opportunity_Line_Schedule_Replacement_Data", Order = 8)]
		public Invoicing_Schedule_Line_for_Opportunity_Line_DataType[] Opportunity_Line_Schedule_Replacement_Data
		{
			get
			{
				return this.opportunity_Line_Schedule_Replacement_DataField;
			}
			set
			{
				this.opportunity_Line_Schedule_Replacement_DataField = value;
				this.RaisePropertyChanged("Opportunity_Line_Schedule_Replacement_Data");
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
