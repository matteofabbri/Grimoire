using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Alternate_Pay_Range_DataType : INotifyPropertyChanged
	{
		private Compensation_Basis_ConfigurableObjectType compensation_Basis_ReferenceField;

		private decimal minimumField;

		private bool minimumFieldSpecified;

		private decimal midpointField;

		private bool midpointFieldSpecified;

		private decimal maximumField;

		private bool maximumFieldSpecified;

		private decimal spreadField;

		private bool spreadFieldSpecified;

		private decimal segment_1_TopField;

		private bool segment_1_TopFieldSpecified;

		private decimal segment_2_TopField;

		private bool segment_2_TopFieldSpecified;

		private decimal segment_3_TopField;

		private bool segment_3_TopFieldSpecified;

		private decimal segment_4_TopField;

		private bool segment_4_TopFieldSpecified;

		private decimal segment_5_TopField;

		private bool segment_5_TopFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Basis_ConfigurableObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Minimum
		{
			get
			{
				return this.minimumField;
			}
			set
			{
				this.minimumField = value;
				this.RaisePropertyChanged("Minimum");
			}
		}

		[XmlIgnore]
		public bool MinimumSpecified
		{
			get
			{
				return this.minimumFieldSpecified;
			}
			set
			{
				this.minimumFieldSpecified = value;
				this.RaisePropertyChanged("MinimumSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Midpoint
		{
			get
			{
				return this.midpointField;
			}
			set
			{
				this.midpointField = value;
				this.RaisePropertyChanged("Midpoint");
			}
		}

		[XmlIgnore]
		public bool MidpointSpecified
		{
			get
			{
				return this.midpointFieldSpecified;
			}
			set
			{
				this.midpointFieldSpecified = value;
				this.RaisePropertyChanged("MidpointSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Maximum
		{
			get
			{
				return this.maximumField;
			}
			set
			{
				this.maximumField = value;
				this.RaisePropertyChanged("Maximum");
			}
		}

		[XmlIgnore]
		public bool MaximumSpecified
		{
			get
			{
				return this.maximumFieldSpecified;
			}
			set
			{
				this.maximumFieldSpecified = value;
				this.RaisePropertyChanged("MaximumSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Spread
		{
			get
			{
				return this.spreadField;
			}
			set
			{
				this.spreadField = value;
				this.RaisePropertyChanged("Spread");
			}
		}

		[XmlIgnore]
		public bool SpreadSpecified
		{
			get
			{
				return this.spreadFieldSpecified;
			}
			set
			{
				this.spreadFieldSpecified = value;
				this.RaisePropertyChanged("SpreadSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Segment_1_Top
		{
			get
			{
				return this.segment_1_TopField;
			}
			set
			{
				this.segment_1_TopField = value;
				this.RaisePropertyChanged("Segment_1_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_1_TopSpecified
		{
			get
			{
				return this.segment_1_TopFieldSpecified;
			}
			set
			{
				this.segment_1_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_1_TopSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Segment_2_Top
		{
			get
			{
				return this.segment_2_TopField;
			}
			set
			{
				this.segment_2_TopField = value;
				this.RaisePropertyChanged("Segment_2_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_2_TopSpecified
		{
			get
			{
				return this.segment_2_TopFieldSpecified;
			}
			set
			{
				this.segment_2_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_2_TopSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Segment_3_Top
		{
			get
			{
				return this.segment_3_TopField;
			}
			set
			{
				this.segment_3_TopField = value;
				this.RaisePropertyChanged("Segment_3_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_3_TopSpecified
		{
			get
			{
				return this.segment_3_TopFieldSpecified;
			}
			set
			{
				this.segment_3_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_3_TopSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Segment_4_Top
		{
			get
			{
				return this.segment_4_TopField;
			}
			set
			{
				this.segment_4_TopField = value;
				this.RaisePropertyChanged("Segment_4_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_4_TopSpecified
		{
			get
			{
				return this.segment_4_TopFieldSpecified;
			}
			set
			{
				this.segment_4_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_4_TopSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Segment_5_Top
		{
			get
			{
				return this.segment_5_TopField;
			}
			set
			{
				this.segment_5_TopField = value;
				this.RaisePropertyChanged("Segment_5_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_5_TopSpecified
		{
			get
			{
				return this.segment_5_TopFieldSpecified;
			}
			set
			{
				this.segment_5_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_5_TopSpecified");
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
