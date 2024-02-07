using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_ID_Data_DisplayType : INotifyPropertyChanged
	{
		private string idField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string assignment_ReasonField;

		private bool automatic_AssignmentField;

		private bool automatic_AssignmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Assignment_Reason
		{
			get
			{
				return this.assignment_ReasonField;
			}
			set
			{
				this.assignment_ReasonField = value;
				this.RaisePropertyChanged("Assignment_Reason");
			}
		}

		[XmlElement(Order = 4)]
		public bool Automatic_Assignment
		{
			get
			{
				return this.automatic_AssignmentField;
			}
			set
			{
				this.automatic_AssignmentField = value;
				this.RaisePropertyChanged("Automatic_Assignment");
			}
		}

		[XmlIgnore]
		public bool Automatic_AssignmentSpecified
		{
			get
			{
				return this.automatic_AssignmentFieldSpecified;
			}
			set
			{
				this.automatic_AssignmentFieldSpecified = value;
				this.RaisePropertyChanged("Automatic_AssignmentSpecified");
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
