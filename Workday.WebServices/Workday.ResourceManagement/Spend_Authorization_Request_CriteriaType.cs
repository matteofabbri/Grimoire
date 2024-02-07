using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_Authorization_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string document_NumberField;

		private DateTime created_Start_DateField;

		private bool created_Start_DateFieldSpecified;

		private DateTime created_End_DateField;

		private bool created_End_DateFieldSpecified;

		private DateTime approved_Start_DateField;

		private bool approved_Start_DateFieldSpecified;

		private DateTime approved_End_DateField;

		private bool approved_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
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
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Document_Number
		{
			get
			{
				return this.document_NumberField;
			}
			set
			{
				this.document_NumberField = value;
				this.RaisePropertyChanged("Document_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Created_Start_Date
		{
			get
			{
				return this.created_Start_DateField;
			}
			set
			{
				this.created_Start_DateField = value;
				this.RaisePropertyChanged("Created_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Created_Start_DateSpecified
		{
			get
			{
				return this.created_Start_DateFieldSpecified;
			}
			set
			{
				this.created_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Created_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Created_End_Date
		{
			get
			{
				return this.created_End_DateField;
			}
			set
			{
				this.created_End_DateField = value;
				this.RaisePropertyChanged("Created_End_Date");
			}
		}

		[XmlIgnore]
		public bool Created_End_DateSpecified
		{
			get
			{
				return this.created_End_DateFieldSpecified;
			}
			set
			{
				this.created_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Created_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Approved_Start_Date
		{
			get
			{
				return this.approved_Start_DateField;
			}
			set
			{
				this.approved_Start_DateField = value;
				this.RaisePropertyChanged("Approved_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Approved_Start_DateSpecified
		{
			get
			{
				return this.approved_Start_DateFieldSpecified;
			}
			set
			{
				this.approved_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Approved_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Approved_End_Date
		{
			get
			{
				return this.approved_End_DateField;
			}
			set
			{
				this.approved_End_DateField = value;
				this.RaisePropertyChanged("Approved_End_Date");
			}
		}

		[XmlIgnore]
		public bool Approved_End_DateSpecified
		{
			get
			{
				return this.approved_End_DateFieldSpecified;
			}
			set
			{
				this.approved_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Approved_End_DateSpecified");
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
