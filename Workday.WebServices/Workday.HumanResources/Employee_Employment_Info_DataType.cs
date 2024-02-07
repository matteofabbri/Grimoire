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
	public class Employee_Employment_Info_DataType : INotifyPropertyChanged
	{
		private Worker_Status_DataType worker_Status_DataField;

		private Worker_Position_DataType worker_Position_DataField;

		private Compensation_DataType compensation_DataField;

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
		public Compensation_DataType Compensation_Data
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

		[XmlArray(Order = 3), XmlArrayItem("Worker_Document", IsNullable = false)]
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
