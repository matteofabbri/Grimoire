using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_Contract_Info_DataType : INotifyPropertyChanged
	{
		private Worker_Status_DataType worker_Status_DataField;

		private Worker_Position_DataType worker_Position_DataField;

		private string contingent_Worker_Type_NameField;

		private Vendor_ReferenceType vendor_Reference_DataField;

		private Contract_Details_DataType contract_Details_DataField;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private Worker_Document_WWSType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Status_DataType Worker_Status_Data
		{
			get
			{
				return this.worker_Status_DataField;
			}
			set
			{
				this.worker_Status_DataField = value;
				this.RaisePropertyChanged("Worker_Status_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Position_DataType Worker_Position_Data
		{
			get
			{
				return this.worker_Position_DataField;
			}
			set
			{
				this.worker_Position_DataField = value;
				this.RaisePropertyChanged("Worker_Position_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Contingent_Worker_Type_Name
		{
			get
			{
				return this.contingent_Worker_Type_NameField;
			}
			set
			{
				this.contingent_Worker_Type_NameField = value;
				this.RaisePropertyChanged("Contingent_Worker_Type_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Vendor_ReferenceType Vendor_Reference_Data
		{
			get
			{
				return this.vendor_Reference_DataField;
			}
			set
			{
				this.vendor_Reference_DataField = value;
				this.RaisePropertyChanged("Vendor_Reference_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Contract_Details_DataType Contract_Details_Data
		{
			get
			{
				return this.contract_Details_DataField;
			}
			set
			{
				this.contract_Details_DataField = value;
				this.RaisePropertyChanged("Contract_Details_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Worker_Document", IsNullable = false)]
		public Worker_Document_WWSType[] Worker_Document_Data
		{
			get
			{
				return this.worker_Document_DataField;
			}
			set
			{
				this.worker_Document_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Data");
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
