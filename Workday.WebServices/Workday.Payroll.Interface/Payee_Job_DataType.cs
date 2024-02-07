using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Job_DataType : INotifyPropertyChanged
	{
		private Position_Employment_DataType payee_Employment_DataField;

		private Position_Compensation_DataType payee_Compensation_DataField;

		private Position_Organization_DataType payee_Organization_DataField;

		private Position_Management_Chain_DataType payee_Management_Chain_DataField;

		private Leave_Status_Detail_DataType[] leave_Status_DataField;

		private Leave_Requests_Corrected_Detail_DataType[] leave_Requests_Corrected_DataField;

		private bool primary_JobField;

		private bool primary_JobFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_Employment_DataType Payee_Employment_Data
		{
			get
			{
				return this.payee_Employment_DataField;
			}
			set
			{
				this.payee_Employment_DataField = value;
				this.RaisePropertyChanged("Payee_Employment_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Position_Compensation_DataType Payee_Compensation_Data
		{
			get
			{
				return this.payee_Compensation_DataField;
			}
			set
			{
				this.payee_Compensation_DataField = value;
				this.RaisePropertyChanged("Payee_Compensation_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Organization_DataType Payee_Organization_Data
		{
			get
			{
				return this.payee_Organization_DataField;
			}
			set
			{
				this.payee_Organization_DataField = value;
				this.RaisePropertyChanged("Payee_Organization_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Position_Management_Chain_DataType Payee_Management_Chain_Data
		{
			get
			{
				return this.payee_Management_Chain_DataField;
			}
			set
			{
				this.payee_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Payee_Management_Chain_Data");
			}
		}

		[XmlElement("Leave_Status_Data", Order = 4)]
		public Leave_Status_Detail_DataType[] Leave_Status_Data
		{
			get
			{
				return this.leave_Status_DataField;
			}
			set
			{
				this.leave_Status_DataField = value;
				this.RaisePropertyChanged("Leave_Status_Data");
			}
		}

		[XmlElement("Leave_Requests_Corrected_Data", Order = 5)]
		public Leave_Requests_Corrected_Detail_DataType[] Leave_Requests_Corrected_Data
		{
			get
			{
				return this.leave_Requests_Corrected_DataField;
			}
			set
			{
				this.leave_Requests_Corrected_DataField = value;
				this.RaisePropertyChanged("Leave_Requests_Corrected_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Primary_Job
		{
			get
			{
				return this.primary_JobField;
			}
			set
			{
				this.primary_JobField = value;
				this.RaisePropertyChanged("Primary_Job");
			}
		}

		[XmlIgnore]
		public bool Primary_JobSpecified
		{
			get
			{
				return this.primary_JobFieldSpecified;
			}
			set
			{
				this.primary_JobFieldSpecified = value;
				this.RaisePropertyChanged("Primary_JobSpecified");
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
