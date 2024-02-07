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
	public class Asset_Transfer_DataType : INotifyPropertyChanged
	{
		private DateTime transfer_DateField;

		private WorkerObjectType transfer_To_Worker_ReferenceField;

		private bool default_Location_and_Worktags_from_WorkerField;

		private bool default_Location_and_Worktags_from_WorkerFieldSpecified;

		private LocationObjectType transfer_To_Location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool keep_Worktags_of_Asset_SharesField;

		private bool keep_Worktags_of_Asset_SharesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transfer_Date
		{
			get
			{
				return this.transfer_DateField;
			}
			set
			{
				this.transfer_DateField = value;
				this.RaisePropertyChanged("Transfer_Date");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Transfer_To_Worker_Reference
		{
			get
			{
				return this.transfer_To_Worker_ReferenceField;
			}
			set
			{
				this.transfer_To_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_To_Worker_Reference");
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
		public LocationObjectType Transfer_To_Location_Reference
		{
			get
			{
				return this.transfer_To_Location_ReferenceField;
			}
			set
			{
				this.transfer_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_To_Location_Reference");
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
