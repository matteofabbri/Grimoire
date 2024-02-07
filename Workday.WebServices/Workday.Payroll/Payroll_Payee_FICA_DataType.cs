using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_FICA_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private bool all_PositionsField;

		private bool all_PositionsFieldSpecified;

		private DateTime effective_As_OfField;

		private Medicare_Exempt_DataType[] medicare_Exempt_DataField;

		private OASDI_Exempt_DataType[] oASDI_Exempt_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool All_Positions
		{
			get
			{
				return this.all_PositionsField;
			}
			set
			{
				this.all_PositionsField = value;
				this.RaisePropertyChanged("All_Positions");
			}
		}

		[XmlIgnore]
		public bool All_PositionsSpecified
		{
			get
			{
				return this.all_PositionsFieldSpecified;
			}
			set
			{
				this.all_PositionsFieldSpecified = value;
				this.RaisePropertyChanged("All_PositionsSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlElement("Medicare_Exempt_Data", Order = 4)]
		public Medicare_Exempt_DataType[] Medicare_Exempt_Data
		{
			get
			{
				return this.medicare_Exempt_DataField;
			}
			set
			{
				this.medicare_Exempt_DataField = value;
				this.RaisePropertyChanged("Medicare_Exempt_Data");
			}
		}

		[XmlElement("OASDI_Exempt_Data", Order = 5)]
		public OASDI_Exempt_DataType[] OASDI_Exempt_Data
		{
			get
			{
				return this.oASDI_Exempt_DataField;
			}
			set
			{
				this.oASDI_Exempt_DataField = value;
				this.RaisePropertyChanged("OASDI_Exempt_Data");
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
