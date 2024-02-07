using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Has_Enrollable_Eligibility_DataType : INotifyPropertyChanged
	{
		private bool unlimited_CapacityField;

		private bool unlimited_CapacityFieldSpecified;

		private decimal section_CapacityField;

		private bool section_CapacityFieldSpecified;

		private decimal wait_List_CapacityField;

		private bool wait_List_CapacityFieldSpecified;

		private decimal reserved_CapacityField;

		private bool reserved_CapacityFieldSpecified;

		private decimal projected_EnrollmentField;

		private bool projected_EnrollmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Unlimited_Capacity
		{
			get
			{
				return this.unlimited_CapacityField;
			}
			set
			{
				this.unlimited_CapacityField = value;
				this.RaisePropertyChanged("Unlimited_Capacity");
			}
		}

		[XmlIgnore]
		public bool Unlimited_CapacitySpecified
		{
			get
			{
				return this.unlimited_CapacityFieldSpecified;
			}
			set
			{
				this.unlimited_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Unlimited_CapacitySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Section_Capacity
		{
			get
			{
				return this.section_CapacityField;
			}
			set
			{
				this.section_CapacityField = value;
				this.RaisePropertyChanged("Section_Capacity");
			}
		}

		[XmlIgnore]
		public bool Section_CapacitySpecified
		{
			get
			{
				return this.section_CapacityFieldSpecified;
			}
			set
			{
				this.section_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Section_CapacitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Wait_List_Capacity
		{
			get
			{
				return this.wait_List_CapacityField;
			}
			set
			{
				this.wait_List_CapacityField = value;
				this.RaisePropertyChanged("Wait_List_Capacity");
			}
		}

		[XmlIgnore]
		public bool Wait_List_CapacitySpecified
		{
			get
			{
				return this.wait_List_CapacityFieldSpecified;
			}
			set
			{
				this.wait_List_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Wait_List_CapacitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Reserved_Capacity
		{
			get
			{
				return this.reserved_CapacityField;
			}
			set
			{
				this.reserved_CapacityField = value;
				this.RaisePropertyChanged("Reserved_Capacity");
			}
		}

		[XmlIgnore]
		public bool Reserved_CapacitySpecified
		{
			get
			{
				return this.reserved_CapacityFieldSpecified;
			}
			set
			{
				this.reserved_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Reserved_CapacitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Projected_Enrollment
		{
			get
			{
				return this.projected_EnrollmentField;
			}
			set
			{
				this.projected_EnrollmentField = value;
				this.RaisePropertyChanged("Projected_Enrollment");
			}
		}

		[XmlIgnore]
		public bool Projected_EnrollmentSpecified
		{
			get
			{
				return this.projected_EnrollmentFieldSpecified;
			}
			set
			{
				this.projected_EnrollmentFieldSpecified = value;
				this.RaisePropertyChanged("Projected_EnrollmentSpecified");
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
