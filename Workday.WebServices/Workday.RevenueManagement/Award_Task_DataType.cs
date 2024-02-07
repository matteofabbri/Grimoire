using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_DataType : INotifyPropertyChanged
	{
		private Award_TaskObjectType award_Task_ReferenceField;

		private string idField;

		private Award_Task_TypeObjectType award_Task_Type_ReferenceField;

		private Award_Contract_LineObjectType award_Line_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private DateTime completed_DateField;

		private bool completed_DateFieldSpecified;

		private Award_Task_StatusObjectType status_ReferenceField;

		private string commentsField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Award_Task_Role_Assignment_DataType[] role_Assignment_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_TaskObjectType Award_Task_Reference
		{
			get
			{
				return this.award_Task_ReferenceField;
			}
			set
			{
				this.award_Task_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Award_Task_TypeObjectType Award_Task_Type_Reference
		{
			get
			{
				return this.award_Task_Type_ReferenceField;
			}
			set
			{
				this.award_Task_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Award_Contract_LineObjectType Award_Line_Reference
		{
			get
			{
				return this.award_Line_ReferenceField;
			}
			set
			{
				this.award_Line_ReferenceField = value;
				this.RaisePropertyChanged("Award_Line_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Completed_Date
		{
			get
			{
				return this.completed_DateField;
			}
			set
			{
				this.completed_DateField = value;
				this.RaisePropertyChanged("Completed_Date");
			}
		}

		[XmlIgnore]
		public bool Completed_DateSpecified
		{
			get
			{
				return this.completed_DateFieldSpecified;
			}
			set
			{
				this.completed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completed_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Award_Task_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement("Attachment_Data", Order = 10)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Role_Assignment_Data", Order = 11)]
		public Award_Task_Role_Assignment_DataType[] Role_Assignment_Data
		{
			get
			{
				return this.role_Assignment_DataField;
			}
			set
			{
				this.role_Assignment_DataField = value;
				this.RaisePropertyChanged("Role_Assignment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
