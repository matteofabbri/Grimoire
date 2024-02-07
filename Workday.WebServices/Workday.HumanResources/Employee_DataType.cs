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
	public class Employee_DataType : INotifyPropertyChanged
	{
		private string employee_IDField;

		private string user_IDField;

		private IDType[] integration_ID_DataField;

		private Personal_Info_DataType[] personal_Info_DataField;

		private Worker_Status_DataType[] worker_Status_DataField;

		private Worker_Position_DataType[] worker_Position_DataField;

		private Compensation_DataType[] compensation_DataField;

		private Compensation_Detail_DataType[] compensation_Detail_DataField;

		private Worker_Document_WWSType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement("Personal_Info_Data", Order = 3)]
		public Personal_Info_DataType[] Personal_Info_Data
		{
			get
			{
				return this.personal_Info_DataField;
			}
			set
			{
				this.personal_Info_DataField = value;
				this.RaisePropertyChanged("Personal_Info_Data");
			}
		}

		[XmlElement("Worker_Status_Data", Order = 4)]
		public Worker_Status_DataType[] Worker_Status_Data
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

		[XmlElement("Worker_Position_Data", Order = 5)]
		public Worker_Position_DataType[] Worker_Position_Data
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

		[XmlElement("Compensation_Data", Order = 6)]
		public Compensation_DataType[] Compensation_Data
		{
			get
			{
				return this.compensation_DataField;
			}
			set
			{
				this.compensation_DataField = value;
				this.RaisePropertyChanged("Compensation_Data");
			}
		}

		[XmlElement("Compensation_Detail_Data", Order = 7)]
		public Compensation_Detail_DataType[] Compensation_Detail_Data
		{
			get
			{
				return this.compensation_Detail_DataField;
			}
			set
			{
				this.compensation_Detail_DataField = value;
				this.RaisePropertyChanged("Compensation_Detail_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Worker_Document", IsNullable = false)]
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
