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
	public class Previous_System_Job_History_Detail_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string worker_History_NameField;

		private DateTime action_DateField;

		private bool action_DateFieldSpecified;

		private string reasonField;

		private string descriptionField;

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
		public string Worker_History_Name
		{
			get
			{
				return this.worker_History_NameField;
			}
			set
			{
				this.worker_History_NameField = value;
				this.RaisePropertyChanged("Worker_History_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Action_Date
		{
			get
			{
				return this.action_DateField;
			}
			set
			{
				this.action_DateField = value;
				this.RaisePropertyChanged("Action_Date");
			}
		}

		[XmlIgnore]
		public bool Action_DateSpecified
		{
			get
			{
				return this.action_DateFieldSpecified;
			}
			set
			{
				this.action_DateFieldSpecified = value;
				this.RaisePropertyChanged("Action_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		[XmlElement(Order = 4)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
