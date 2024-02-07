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
	public class Project_Phase_DataType : INotifyPropertyChanged
	{
		private string phase_IDField;

		private string phase_NameField;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Phase_ID
		{
			get
			{
				return this.phase_IDField;
			}
			set
			{
				this.phase_IDField = value;
				this.RaisePropertyChanged("Phase_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Phase_Name
		{
			get
			{
				return this.phase_NameField;
			}
			set
			{
				this.phase_NameField = value;
				this.RaisePropertyChanged("Phase_Name");
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
