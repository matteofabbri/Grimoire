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
	public class ASN_Line_Lot_Information_Data_OutboundType : INotifyPropertyChanged
	{
		private string lot_IdentifierField;

		private DateTime manufacture_DateField;

		private bool manufacture_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Lot_Identifier
		{
			get
			{
				return this.lot_IdentifierField;
			}
			set
			{
				this.lot_IdentifierField = value;
				this.RaisePropertyChanged("Lot_Identifier");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Manufacture_Date
		{
			get
			{
				return this.manufacture_DateField;
			}
			set
			{
				this.manufacture_DateField = value;
				this.RaisePropertyChanged("Manufacture_Date");
			}
		}

		[XmlIgnore]
		public bool Manufacture_DateSpecified
		{
			get
			{
				return this.manufacture_DateFieldSpecified;
			}
			set
			{
				this.manufacture_DateFieldSpecified = value;
				this.RaisePropertyChanged("Manufacture_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
