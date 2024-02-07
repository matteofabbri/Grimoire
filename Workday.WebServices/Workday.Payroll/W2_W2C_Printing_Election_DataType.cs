using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "W-2_W-2C_Printing_Election_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class W2_W2C_Printing_Election_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Unique_IdentifierObjectType tax_Document_Delivery_ReferenceField;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		private string current_W2_W2C_Printing_ElectionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Tax_Document_Delivery_Reference
		{
			get
			{
				return this.tax_Document_Delivery_ReferenceField;
			}
			set
			{
				this.tax_Document_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Document_Delivery_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Last_UpdatedSpecified
		{
			get
			{
				return this.last_UpdatedFieldSpecified;
			}
			set
			{
				this.last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Last_UpdatedSpecified");
			}
		}

		[XmlElement("Current_W-2_W-2C_Printing_Election", Order = 3)]
		public string Current_W2_W2C_Printing_Election
		{
			get
			{
				return this.current_W2_W2C_Printing_ElectionField;
			}
			set
			{
				this.current_W2_W2C_Printing_ElectionField = value;
				this.RaisePropertyChanged("Current_W2_W2C_Printing_Election");
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
