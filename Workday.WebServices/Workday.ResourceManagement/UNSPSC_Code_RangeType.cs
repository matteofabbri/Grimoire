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
	public class UNSPSC_Code_RangeType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType uNSPSC_Value_ReferenceField;

		private decimal range_FromField;

		private bool range_FromFieldSpecified;

		private decimal range_ToField;

		private bool range_ToFieldSpecified;

		private bool use_on_POField;

		private bool use_on_POFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType UNSPSC_Value_Reference
		{
			get
			{
				return this.uNSPSC_Value_ReferenceField;
			}
			set
			{
				this.uNSPSC_Value_ReferenceField = value;
				this.RaisePropertyChanged("UNSPSC_Value_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Range_From
		{
			get
			{
				return this.range_FromField;
			}
			set
			{
				this.range_FromField = value;
				this.RaisePropertyChanged("Range_From");
			}
		}

		[XmlIgnore]
		public bool Range_FromSpecified
		{
			get
			{
				return this.range_FromFieldSpecified;
			}
			set
			{
				this.range_FromFieldSpecified = value;
				this.RaisePropertyChanged("Range_FromSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Range_To
		{
			get
			{
				return this.range_ToField;
			}
			set
			{
				this.range_ToField = value;
				this.RaisePropertyChanged("Range_To");
			}
		}

		[XmlIgnore]
		public bool Range_ToSpecified
		{
			get
			{
				return this.range_ToFieldSpecified;
			}
			set
			{
				this.range_ToFieldSpecified = value;
				this.RaisePropertyChanged("Range_ToSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Use_on_PO
		{
			get
			{
				return this.use_on_POField;
			}
			set
			{
				this.use_on_POField = value;
				this.RaisePropertyChanged("Use_on_PO");
			}
		}

		[XmlIgnore]
		public bool Use_on_POSpecified
		{
			get
			{
				return this.use_on_POFieldSpecified;
			}
			set
			{
				this.use_on_POFieldSpecified = value;
				this.RaisePropertyChanged("Use_on_POSpecified");
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
