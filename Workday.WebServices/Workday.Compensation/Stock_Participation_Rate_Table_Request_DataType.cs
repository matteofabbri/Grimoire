using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Participation_Rate_Table_Request_DataType : INotifyPropertyChanged
	{
		private Stock_Participation_Rate_Table_Entry_Request_DataType[] stock_Participation_Rate_Table_Entry_DataField;

		private string stock_Participation_Rate_Table_IDField;

		private string nameField;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private decimal default_Percentage_RateField;

		private bool default_Percentage_RateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Stock_Participation_Rate_Table_Entry_Data", Order = 0)]
		public Stock_Participation_Rate_Table_Entry_Request_DataType[] Stock_Participation_Rate_Table_Entry_Data
		{
			get
			{
				return this.stock_Participation_Rate_Table_Entry_DataField;
			}
			set
			{
				this.stock_Participation_Rate_Table_Entry_DataField = value;
				this.RaisePropertyChanged("Stock_Participation_Rate_Table_Entry_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Stock_Participation_Rate_Table_ID
		{
			get
			{
				return this.stock_Participation_Rate_Table_IDField;
			}
			set
			{
				this.stock_Participation_Rate_Table_IDField = value;
				this.RaisePropertyChanged("Stock_Participation_Rate_Table_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public decimal Default_Percentage_Rate
		{
			get
			{
				return this.default_Percentage_RateField;
			}
			set
			{
				this.default_Percentage_RateField = value;
				this.RaisePropertyChanged("Default_Percentage_Rate");
			}
		}

		[XmlIgnore]
		public bool Default_Percentage_RateSpecified
		{
			get
			{
				return this.default_Percentage_RateFieldSpecified;
			}
			set
			{
				this.default_Percentage_RateFieldSpecified = value;
				this.RaisePropertyChanged("Default_Percentage_RateSpecified");
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
