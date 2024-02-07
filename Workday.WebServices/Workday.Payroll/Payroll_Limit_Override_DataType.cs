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
	public class Payroll_Limit_Override_DataType : INotifyPropertyChanged
	{
		private string idField;

		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Limit_Interface_DataType[] limit_Interface_DataField;

		private DateTime period_Start_DateField;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private bool use_Limit_Override_ValueField;

		private bool use_Limit_Override_ValueFieldSpecified;

		private decimal limit_Override_ValueField;

		private bool limit_Override_ValueFieldSpecified;

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

		[XmlElement(Order = 2)]
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

		[XmlElement("Limit_Interface_Data", Order = 3)]
		public Limit_Interface_DataType[] Limit_Interface_Data
		{
			get
			{
				return this.limit_Interface_DataField;
			}
			set
			{
				this.limit_Interface_DataField = value;
				this.RaisePropertyChanged("Limit_Interface_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Use_Limit_Override_Value
		{
			get
			{
				return this.use_Limit_Override_ValueField;
			}
			set
			{
				this.use_Limit_Override_ValueField = value;
				this.RaisePropertyChanged("Use_Limit_Override_Value");
			}
		}

		[XmlIgnore]
		public bool Use_Limit_Override_ValueSpecified
		{
			get
			{
				return this.use_Limit_Override_ValueFieldSpecified;
			}
			set
			{
				this.use_Limit_Override_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Use_Limit_Override_ValueSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Limit_Override_Value
		{
			get
			{
				return this.limit_Override_ValueField;
			}
			set
			{
				this.limit_Override_ValueField = value;
				this.RaisePropertyChanged("Limit_Override_Value");
			}
		}

		[XmlIgnore]
		public bool Limit_Override_ValueSpecified
		{
			get
			{
				return this.limit_Override_ValueFieldSpecified;
			}
			set
			{
				this.limit_Override_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Limit_Override_ValueSpecified");
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
