using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Worktag_Mapping_Source_System_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string source_System_NameField;

		private string descriptionField;

		private decimal usage_CountField;

		private bool usage_CountFieldSpecified;

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
		public string Source_System_Name
		{
			get
			{
				return this.source_System_NameField;
			}
			set
			{
				this.source_System_NameField = value;
				this.RaisePropertyChanged("Source_System_Name");
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

		[XmlElement(Order = 3)]
		public decimal Usage_Count
		{
			get
			{
				return this.usage_CountField;
			}
			set
			{
				this.usage_CountField = value;
				this.RaisePropertyChanged("Usage_Count");
			}
		}

		[XmlIgnore]
		public bool Usage_CountSpecified
		{
			get
			{
				return this.usage_CountFieldSpecified;
			}
			set
			{
				this.usage_CountFieldSpecified = value;
				this.RaisePropertyChanged("Usage_CountSpecified");
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
