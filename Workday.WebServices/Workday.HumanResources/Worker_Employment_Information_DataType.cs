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
	public class Worker_Employment_Information_DataType : INotifyPropertyChanged
	{
		private Worker_Job_DataType[] worker_Job_DataField;

		private Worker_Status_Detail_DataType worker_Status_DataField;

		private Worker_Contract_Detail_DataType worker_Contract_DataField;

		private International_Assignment_Summary_DataType international_Assignment_Summary_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Job_Data", Order = 0)]
		public Worker_Job_DataType[] Worker_Job_Data
		{
			get
			{
				return this.worker_Job_DataField;
			}
			set
			{
				this.worker_Job_DataField = value;
				this.RaisePropertyChanged("Worker_Job_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Status_Detail_DataType Worker_Status_Data
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

		[XmlElement(Order = 2)]
		public Worker_Contract_Detail_DataType Worker_Contract_Data
		{
			get
			{
				return this.worker_Contract_DataField;
			}
			set
			{
				this.worker_Contract_DataField = value;
				this.RaisePropertyChanged("Worker_Contract_Data");
			}
		}

		[XmlElement(Order = 3)]
		public International_Assignment_Summary_DataType International_Assignment_Summary_Data
		{
			get
			{
				return this.international_Assignment_Summary_DataField;
			}
			set
			{
				this.international_Assignment_Summary_DataField = value;
				this.RaisePropertyChanged("International_Assignment_Summary_Data");
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
