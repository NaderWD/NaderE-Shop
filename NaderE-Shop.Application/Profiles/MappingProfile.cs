using AutoMapper;
using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using NaderE_Shop.Application.DTOs.CommentDTO;
using NaderE_Shop.Application.DTOs.CustomerDTO;
using NaderE_Shop.Application.DTOs.OrderDTO;
using NaderE_Shop.Application.DTOs.ProductDTO;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.DTOs.ShopUserDTO;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Address

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Address, AddressListDto>().ReverseMap();
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, UpdateAddressDto>().ReverseMap();

            #endregion



            #region Base

            CreateMap<Base, BaseDto>().ReverseMap();

            #endregion



            #region Category

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            #endregion



            #region Comment

            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Comment, CommentListDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();

            #endregion



            #region Customer

            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CustomerListDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();

            #endregion



            #region Order

            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, OrderListDto>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();

            #endregion



            #region Product

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

            #endregion



            #region ShoppingCart

            CreateMap<ShoppingCart, ShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, ShoppingCartListDto>().ReverseMap();
            CreateMap<ShoppingCart, CreateShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, UpdateShoppingCartDto>().ReverseMap();

            #endregion



            #region ShopUser

            CreateMap<ShopUser, ShopUserDto>().ReverseMap();
            CreateMap<ShopUser, ShopUserListDto>().ReverseMap();
            CreateMap<ShopUser, CreateShopUserDto>().ReverseMap();
            CreateMap<ShopUser, UpdateShopUserDto>().ReverseMap();

            #endregion
        }
    }
}
