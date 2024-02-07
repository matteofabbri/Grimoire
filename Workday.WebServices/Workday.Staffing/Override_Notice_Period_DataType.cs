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
	public class Override_Notice_Period_DataType : INotifyPropertyChanged
	{
		private decimal durationField;

		private bool durationFieldSpecified;

		private Unique_IdentifierObjectType unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("Duration");
			}
		}

		[XmlIgnore]
		public bool DurationSpecified
		{
			get
			{
				return this.durationFieldSpecified;
			}
			set
			{
				this.durationFieldSpecified = value;
				this.RaisePropertyChanged("DurationSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Unit_Reference
		{
			get
			{
				return this.unit_ReferenceField;
			}
			set
			{
				this.unit_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Reference");
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
