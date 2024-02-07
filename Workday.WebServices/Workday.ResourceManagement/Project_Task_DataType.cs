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
	public class Project_Task_DataType : INotifyPropertyChanged
	{
		private string task_IDField;

		private string task_NameField;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Task_ID
		{
			get
			{
				return this.task_IDField;
			}
			set
			{
				this.task_IDField = value;
				this.RaisePropertyChanged("Task_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Task_Name
		{
			get
			{
				return this.task_NameField;
			}
			set
			{
				this.task_NameField = value;
				this.RaisePropertyChanged("Task_Name");
			}
		}

		[XmlElement(Order = 2)]
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
