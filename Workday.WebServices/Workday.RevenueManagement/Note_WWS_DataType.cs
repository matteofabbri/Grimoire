using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Note_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime createdField;

		private bool createdFieldSpecified;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private Business_Entity_ContactObjectType business_Entity_Contact_ReferenceField;

		private System_UserObjectType system_User_ReferenceField;

		private string note_ContentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Created
		{
			get
			{
				return this.createdField;
			}
			set
			{
				this.createdField = value;
				this.RaisePropertyChanged("Created");
			}
		}

		[XmlIgnore]
		public bool CreatedSpecified
		{
			get
			{
				return this.createdFieldSpecified;
			}
			set
			{
				this.createdFieldSpecified = value;
				this.RaisePropertyChanged("CreatedSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Last_UpdatedSpecified
		{
			get
			{
				return this.last_UpdatedFieldSpecified;
			}
			set
			{
				this.last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Last_UpdatedSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Business_Entity_ContactObjectType Business_Entity_Contact_Reference
		{
			get
			{
				return this.business_Entity_Contact_ReferenceField;
			}
			set
			{
				this.business_Entity_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Business_Entity_Contact_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public System_UserObjectType System_User_Reference
		{
			get
			{
				return this.system_User_ReferenceField;
			}
			set
			{
				this.system_User_ReferenceField = value;
				this.RaisePropertyChanged("System_User_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Note_Content
		{
			get
			{
				return this.note_ContentField;
			}
			set
			{
				this.note_ContentField = value;
				this.RaisePropertyChanged("Note_Content");
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
