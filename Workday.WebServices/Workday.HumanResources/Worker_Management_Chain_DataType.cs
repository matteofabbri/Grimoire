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
	public class Worker_Management_Chain_DataType : INotifyPropertyChanged
	{
		private Management_Chain_DataType[] worker_Supervisory_Management_Chain_DataField;

		private Management_Chain_DataType[] worker_Matrix_Management_Chain_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Management_Chain_Data", IsNullable = false)]
		public Management_Chain_DataType[] Worker_Supervisory_Management_Chain_Data
		{
			get
			{
				return this.worker_Supervisory_Management_Chain_DataField;
			}
			set
			{
				this.worker_Supervisory_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Worker_Supervisory_Management_Chain_Data");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Management_Chain_Data", IsNullable = false)]
		public Management_Chain_DataType[] Worker_Matrix_Management_Chain_Data
		{
			get
			{
				return this.worker_Matrix_Management_Chain_DataField;
			}
			set
			{
				this.worker_Matrix_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Worker_Matrix_Management_Chain_Data");
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
