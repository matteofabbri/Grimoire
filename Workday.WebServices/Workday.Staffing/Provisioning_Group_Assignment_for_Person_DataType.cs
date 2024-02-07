using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Provisioning_Group_Assignment_for_Person_DataType : INotifyPropertyChanged
	{
		private string provisioning_GroupField;

		private string statusField;

		private DateTime last_ChangedField;

		private bool last_ChangedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Provisioning_Group
		{
			get
			{
				return this.provisioning_GroupField;
			}
			set
			{
				this.provisioning_GroupField = value;
				this.RaisePropertyChanged("Provisioning_Group");
			}
		}

		[XmlElement(Order = 1)]
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Last_Changed
		{
			get
			{
				return this.last_ChangedField;
			}
			set
			{
				this.last_ChangedField = value;
				this.RaisePropertyChanged("Last_Changed");
			}
		}

		[XmlIgnore]
		public bool Last_ChangedSpecified
		{
			get
			{
				return this.last_ChangedFieldSpecified;
			}
			set
			{
				this.last_ChangedFieldSpecified = value;
				this.RaisePropertyChanged("Last_ChangedSpecified");
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
