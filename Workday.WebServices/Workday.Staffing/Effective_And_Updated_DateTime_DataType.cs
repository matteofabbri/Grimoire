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
	public class Effective_And_Updated_DateTime_DataType : INotifyPropertyChanged
	{
		private DateTime updated_FromField;

		private bool updated_FromFieldSpecified;

		private DateTime updated_ThroughField;

		private bool updated_ThroughFieldSpecified;

		private DateTime effective_FromField;

		private bool effective_FromFieldSpecified;

		private DateTime effective_ThroughField;

		private bool effective_ThroughFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Updated_From
		{
			get
			{
				return this.updated_FromField;
			}
			set
			{
				this.updated_FromField = value;
				this.RaisePropertyChanged("Updated_From");
			}
		}

		[XmlIgnore]
		public bool Updated_FromSpecified
		{
			get
			{
				return this.updated_FromFieldSpecified;
			}
			set
			{
				this.updated_FromFieldSpecified = value;
				this.RaisePropertyChanged("Updated_FromSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Updated_Through
		{
			get
			{
				return this.updated_ThroughField;
			}
			set
			{
				this.updated_ThroughField = value;
				this.RaisePropertyChanged("Updated_Through");
			}
		}

		[XmlIgnore]
		public bool Updated_ThroughSpecified
		{
			get
			{
				return this.updated_ThroughFieldSpecified;
			}
			set
			{
				this.updated_ThroughFieldSpecified = value;
				this.RaisePropertyChanged("Updated_ThroughSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Effective_From
		{
			get
			{
				return this.effective_FromField;
			}
			set
			{
				this.effective_FromField = value;
				this.RaisePropertyChanged("Effective_From");
			}
		}

		[XmlIgnore]
		public bool Effective_FromSpecified
		{
			get
			{
				return this.effective_FromFieldSpecified;
			}
			set
			{
				this.effective_FromFieldSpecified = value;
				this.RaisePropertyChanged("Effective_FromSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Effective_Through
		{
			get
			{
				return this.effective_ThroughField;
			}
			set
			{
				this.effective_ThroughField = value;
				this.RaisePropertyChanged("Effective_Through");
			}
		}

		[XmlIgnore]
		public bool Effective_ThroughSpecified
		{
			get
			{
				return this.effective_ThroughFieldSpecified;
			}
			set
			{
				this.effective_ThroughFieldSpecified = value;
				this.RaisePropertyChanged("Effective_ThroughSpecified");
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
