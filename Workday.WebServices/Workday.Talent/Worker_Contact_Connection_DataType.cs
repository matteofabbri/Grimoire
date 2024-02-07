using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Contact_Connection_DataType : INotifyPropertyChanged
	{
		private string idField;

		private WorkerObjectType worker_Connection_Initiator_ReferenceField;

		private WorkerObjectType worker_Connection_ReferenceField;

		private DateTime connection_Start_DateField;

		private DateTime connection_End_DateField;

		private bool connection_End_DateFieldSpecified;

		private Worker_Contact_ConnectionObjectType worker_Contact_Connection_ReferenceField;

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
		public WorkerObjectType Worker_Connection_Initiator_Reference
		{
			get
			{
				return this.worker_Connection_Initiator_ReferenceField;
			}
			set
			{
				this.worker_Connection_Initiator_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Connection_Initiator_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Worker_Connection_Reference
		{
			get
			{
				return this.worker_Connection_ReferenceField;
			}
			set
			{
				this.worker_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Connection_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Connection_Start_Date
		{
			get
			{
				return this.connection_Start_DateField;
			}
			set
			{
				this.connection_Start_DateField = value;
				this.RaisePropertyChanged("Connection_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Connection_End_Date
		{
			get
			{
				return this.connection_End_DateField;
			}
			set
			{
				this.connection_End_DateField = value;
				this.RaisePropertyChanged("Connection_End_Date");
			}
		}

		[XmlIgnore]
		public bool Connection_End_DateSpecified
		{
			get
			{
				return this.connection_End_DateFieldSpecified;
			}
			set
			{
				this.connection_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Connection_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Worker_Contact_ConnectionObjectType Worker_Contact_Connection_Reference
		{
			get
			{
				return this.worker_Contact_Connection_ReferenceField;
			}
			set
			{
				this.worker_Contact_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Contact_Connection_Reference");
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
