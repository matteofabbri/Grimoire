using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Issue_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private WorkerObjectType issue_To_ReferenceField;

		private bool default_Location_and_Worktags_from_WorkerField;

		private bool default_Location_and_Worktags_from_WorkerFieldSpecified;

		private LocationObjectType location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool keep_Worktags_of_Asset_SharesField;

		private bool keep_Worktags_of_Asset_SharesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Issue_To_Reference
		{
			get
			{
				return this.issue_To_ReferenceField;
			}
			set
			{
				this.issue_To_ReferenceField = value;
				this.RaisePropertyChanged("Issue_To_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Default_Location_and_Worktags_from_Worker
		{
			get
			{
				return this.default_Location_and_Worktags_from_WorkerField;
			}
			set
			{
				this.default_Location_and_Worktags_from_WorkerField = value;
				this.RaisePropertyChanged("Default_Location_and_Worktags_from_Worker");
			}
		}

		[XmlIgnore]
		public bool Default_Location_and_Worktags_from_WorkerSpecified
		{
			get
			{
				return this.default_Location_and_Worktags_from_WorkerFieldSpecified;
			}
			set
			{
				this.default_Location_and_Worktags_from_WorkerFieldSpecified = value;
				this.RaisePropertyChanged("Default_Location_and_Worktags_from_WorkerSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 4)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Keep_Worktags_of_Asset_Shares
		{
			get
			{
				return this.keep_Worktags_of_Asset_SharesField;
			}
			set
			{
				this.keep_Worktags_of_Asset_SharesField = value;
				this.RaisePropertyChanged("Keep_Worktags_of_Asset_Shares");
			}
		}

		[XmlIgnore]
		public bool Keep_Worktags_of_Asset_SharesSpecified
		{
			get
			{
				return this.keep_Worktags_of_Asset_SharesFieldSpecified;
			}
			set
			{
				this.keep_Worktags_of_Asset_SharesFieldSpecified = value;
				this.RaisePropertyChanged("Keep_Worktags_of_Asset_SharesSpecified");
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
